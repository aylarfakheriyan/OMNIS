# OMNIS — AI Cultural Mediator

### Research through Design Prototype by Aylar Fakherian

OMNIS is an early Research through Design (RtD) prototype exploring how AI-mediated interaction can support cultural heritage interpretation through an interactive Unity experience.

The project investigates the use of a locally hosted Large Language Model (LLM) as an AI cultural mediator within an interactive system, focusing on how conversational interaction can contribute to culturally informed digital experiences.

---

<p align="center">
  <img src="Docs/omnis-ai-cultural-mediator.png" alt="OMNIS — AI Cultural Mediator by Aylar Fakherian" width="100%">
</p>

<p align="center">
  <img src="Docs/omnis-demo.gif" alt="OMNIS AI Cultural Mediator Unity Prototype Demo" width="100%">
</p>

---

## About the Project

OMNIS is a Unity-based prototype developed as part of an ongoing Research through Design investigation into AI-mediated cultural experiences.

The current prototype explores how an existing Large Language Model can be integrated into an interactive environment to support dialogue around Persian cultural heritage.

Rather than developing a new AI model, OMNIS investigates the design and interaction possibilities of using an existing locally hosted LLM as a mediator between users and culturally informed digital content.

The prototype represents an early technical milestone within a broader exploration of AI, immersive experiences, and Digital Cultural Heritage.

---

## Research Perspective

OMNIS explores the following question:

> How might AI-mediated interaction support meaningful engagement with cultural heritage within interactive digital experiences?

The project approaches AI as an **interaction and mediation layer**, rather than as the primary research subject.

This allows the prototype to investigate how conversational systems can shape the conditions through which users encounter, interpret, and engage with cultural content.

---

## Research Approach

The project is situated within:

- Research through Design (RtD)
- Practice-Based Research (PBR)
- Human-Centred Design
- AI-mediated interaction
- Digital Cultural Heritage
- Interactive experience design

---

## Current Capabilities

The current prototype demonstrates:

- Unity-to-LLM communication
- Connection to a locally hosted LLM
- Direct prompt input from Unity
- AI-generated responses
- Configurable model selection
- Dedicated system prompt
- Local inference using Ollama
- Interactive conversational interface

---

## Technical Architecture

The current communication pipeline is:

```text
User
  ↓
Unity Interface
  ↓
C# / HttpClient
  ↓
Ollama Local API
  ↓
Qwen2.5 3B
  ↓
Generated Response
  ↓
Unity Interface
```

---

## Technology

- Unity 2022
- C#
- Ollama
- Qwen2.5 3B
- TextMeshPro
- .NET HttpClient
- Git & GitHub

---

## Cultural Scope

The current prototype is designed around Persian cultural heritage.

The system prompt constrains the interaction toward culturally relevant content and provides a controlled environment for exploring AI-mediated cultural interpretation.

This prototype is not intended to replace cultural interpretation or human judgement. Instead, it investigates how AI can be positioned as a mediator within a human-centred interactive experience.

---

## Project Status

🚧 **Prototype v0.1**

Current development focuses on:

- Unity ↔ Ollama integration
- AI interaction prototyping
- Prompt design
- User interface development
- Local LLM inference
- Exploration of AI-mediated cultural interaction

OMNIS is an ongoing research prototype and will continue to evolve alongside the broader Research through Design investigation.

---

## Research Direction

Future development will explore how AI mediation can be incorporated into immersive and interactive cultural experiences while maintaining:

- Cultural coherence
- Human agency
- Interpretive openness
- Meaningful interaction
- Transparency of AI mediation

The long-term research direction connects OMNIS with broader investigations into **XR, AI-mediated experiences, and Digital Cultural Heritage**.

---

## Author

**Aylar Fakherian**

Human-Centred Designer | Research through Design

Research interests:

**XR · AI-Mediated Experiences · Digital Cultural Heritage · Interactive Systems · Human-Centred Design**

---

## Related Work

### Simurgh — Interactive VR Experience

A Research through Design project exploring immersive Virtual Reality experiences for Digital Cultural Heritage.

[View the Simurgh Research Repository](https://github.com/aylarfakheriyan/Simurgh-RtD)

[View the Simurgh Project Page](https://aylarfakheriyan.github.io/Simurgh-RtD/)

---

## Repository

This repository documents the development of OMNIS, including prototype implementation, technical experiments, interaction design, and ongoing research development.

The project is maintained as part of an ongoing Research through Design investigation into AI-mediated cultural experiences.

---

## Keywords

Research through Design · Practice-Based Research · AI-Mediated Interaction · Artificial Intelligence · Cultural Heritage · Digital Cultural Heritage · Virtual Reality · XR · Human-Centred Design · Interactive Systems · Immersive Experiences · Unity · Ollama · Large Language Models
