 CyberBot

CyberBot is a C# console-based cybersecurity awareness chatbot that educates users about online safety topics such as phishing, password security, and safe browsing. It includes an ASCII art logo, voice greeting, and interactive chat system.

 Features
 Interactive chatbot (console-based)
 Cybersecurity education (phishing, passwords, browsing safety)
 ASCII art startup logo (image-to-ASCII conversion)
 Voice greeting using WAV playback
 Natural conversation handling
 Typing effect for realistic responses
 Stop-word filtering for better NLP-style responses
 CI-safe mode support (GitHub Actions compatible)
 Project Structure
CyberBot/
│
├── Program.cs
├── human_interraction.cs
├── AsciiLogo.cs
├── voice_greeting.cs
├── greeting.wav
├── CyberBotimage.jpg
└── .github/
    └── workflows/
        └── ci.yml
Technologies Used
C# (.NET)
System.Console
System.Drawing (image processing)
System.Media (audio playback)
GitHub Actions (CI/CD)
 How to Run
1. Clone the repository
git clone https://github.com/st10481327/CyberBot.git
cd CyberBot
2. Open in Visual Studio
Open the .sln file (or create one if needed)
Restore NuGet packages if required
3. Run the project
dotnet run
 How CyberBot Works
Displays ASCII logo on startup
Plays a voice greeting (greeting.wav)
Asks user for their name
Starts chatbot session
Responds to cybersecurity-related questions

Example:

You: what is phishing
CyberBot: Phishing is when scammers pretend to be trusted sources...
CI (Continuous Integration)

This project includes a GitHub Actions workflow to automatically build and test the application.

CI Behavior:
Builds project on every push
Runs in non-interactive mode
Skips chatbot loop using CI=true
CI Workflow File:
.github/workflows/ci.yml
 CI Mode (Important)

To prevent hanging in automated builds:

if (Environment.GetEnvironmentVariable("CI") == "true")
{
    Console.WriteLine("CI Mode: CyberBot startup only");
    return;
}
 Assets Required

Make sure these files exist in your output directory:

CyberBotimage.jpg → ASCII logo image
greeting.wav → voice greeting sound
 Known Limitations
Requires valid image path for ASCII rendering
Console-based (no GUI)
Voice playback may not work on all CI environments
Chat runs indefinitely until user types exit
 Future Improvements
Add machine learning-based NLP responses
Convert to web-based chatbot
Improve ASCII rendering quality
Add logging and analytics
Expand cybersecurity knowledge base
 Author

CyberBot Project
Created as a cybersecurity awareness learning tool in C#.

If you want, I can also:
 Add badges (build passing, .NET version, etc.)
 Turn this into a GitHub-ready professional portfolio repo
 Or generate a full .sln structure for Visual Studio
