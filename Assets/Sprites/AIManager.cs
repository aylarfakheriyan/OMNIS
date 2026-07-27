using UnityEngine;
using TMPro;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

public class AIManager : MonoBehaviour
{
    [Header("UI")]
    public TMP_InputField inputField;
    public TMP_Text responseText;

    [Header("OMNIS Settings")]
    public string modelName = "qwen2.5:3b";
    public string ollamaURL = "http://127.0.0.1:11434/api/generate";

    private static readonly HttpClient client = new HttpClient();

    //----------------------------------------------------

    public void SendQuestion()
    {
        string question = inputField.text.Trim();

        if (string.IsNullOrEmpty(question))
        {
            responseText.text =
@"Please enter a cultural question.

Examples:

• Persian Architecture
• Chinese Art
• Egyptian Civilization
• Greek Mythology";
            return;
        }

        responseText.text = "OMNIS is thinking...";

        _ = AskOmnis(question);
    }

    //----------------------------------------------------

    async Task AskOmnis(string userQuestion)
    {
        try
        {
            string prompt =
                OmnisPrompt.SystemPrompt +
                "\n\nUser Question:\n" +
                userQuestion;

            string json =
                "{"
                + "\"model\":\"" + modelName + "\","
                + "\"prompt\":\"" + EscapeJson(prompt) + "\","
                + "\"stream\":false"
                + "}";

            var content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

            HttpResponseMessage response =
                await client.PostAsync(
                    ollamaURL,
                    content
                );

            string result =
                await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MainThreadDispatcher.Run(() =>
                {
                    responseText.text =
@"OMNIS could not generate a response.

Please verify:

• Ollama is running
• The selected model exists
• The local server is available";
                });

                return;
            }

            string answer = ExtractResponse(result);

            MainThreadDispatcher.Run(() =>
            {
                responseText.text = answer;
            });
        }
        catch (HttpRequestException)
        {
            MainThreadDispatcher.Run(() =>
            {
                responseText.text =
@"Unable to connect to OMNIS.

Make sure:

• Ollama is open
• Local server is running
• Port 11434 is available";
            });
        }
        catch (System.Exception ex)
        {
            MainThreadDispatcher.Run(() =>
            {
                responseText.text =
@"Unexpected Error

" + ex.Message;
            });
        }
    }

    //----------------------------------------------------

    string EscapeJson(string text)
    {
        return text
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\r", "")
            .Replace("\n", "\\n");
    }

    //----------------------------------------------------

    string ExtractResponse(string json)
    {
        const string key = "\"response\":\"";

        int start = json.IndexOf(key);

        if (start < 0)
            return "OMNIS could not read the model response.";

        start += key.Length;

        int end = json.IndexOf("\",\"done\"", start);

        if (end < 0)
            return "OMNIS received an incomplete response.";

        return json
            .Substring(start, end - start)
            .Replace("\\n", "\n")
            .Replace("\\\"", "\"");
    }
}