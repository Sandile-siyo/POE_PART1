# POE_PART1 ChatBot

A console-based chatbot application written in C#.  
This project combines multimedia features (audio + ASCII art) with an interactive chatbot designed to promote **cyber safety awareness**.

---

## Features
- **Voice Greeting**: Plays a `.wav` audio file (`sandi.wav`) at startup.
- **ASCII Logo Rendering**: Converts an image (`logo2.jpg`) into ASCII art and displays it in the console.
- **Interactive Chat**:
  - Prompts the user for their name and validates input.
  - Greets the user with a personalized welcome message.
  - Provides cybersecurity tips and awareness through natural conversation.
- **Cybersecurity Topics Covered**:
  - Phishing awareness
  - Safe browsing practices
  - Malware protection
  - Social media safety
  - Public Wi-Fi safety
  - Two-factor authentication
  - Importance of updates
  - General cybersecurity awareness
- **Threaded Audio Playback**: Runs the voice greeting on a separate thread for smoother execution.
- **Typewriter Effect**: Responses are displayed slowly for a more engaging experience.
- **Object-Oriented Design**:
  - `Program` → Application entry point
  - `LogoAndVoice` → Handles audio playback and ASCII logo rendering
  - `UserInterface` → Manages user input/output and validation
  - `ChatBotEngine` → Core chatbot logic and cybersecurity responses

---

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later recommended)
- A C# IDE (Visual Studio, Rider, or VS Code with C# extension)
- Media files:
  - `sandi.wav` (voice greeting)
  - `logo2.jpg` (logo image)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/POE_PART1.git
   cd POE_PART1
