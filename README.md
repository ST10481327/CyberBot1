# 🤖 CyberBot

CyberBot is a **C# console-based chatbot** designed to educate users about cybersecurity topics such as phishing, password safety, and secure browsing.

---

## ▶️ How the Code Runs

The application follows a structured execution flow starting from the `Main` method.

### 1. Program Entry Point

The program starts in:


Program.cs


```csharp
static void Main(string[] args)
{
    new voice_greeting();   // Plays sound
    new AsciiLogo();        // Displays ASCII logo

    human_interraction bot = new human_interraction();
    bot.Start();            // Starts chatbot
}
2. Voice Greeting

The voice_greeting class:

Plays a .wav audio file (greeting.wav)
Uses SoundPlayer
If the file is missing → shows error message
3. ASCII Logo Display

The AsciiLogo class:

Loads an image (CyberBotimage.jpg)
Converts it into ASCII characters
Displays it in the console
Uses System.Drawing

If the image is missing:

Image not found.
4. Chatbot Logic

The human_interraction class:

🔹 Step 1: Ask User Name
Prompts user input
Prevents empty input
🔹 Step 2: Welcome Message
Greets user
Explains chatbot purpose
🔹 Step 3: Chat Loop
Runs continuously until user types exit
Accepts user input
Processes keywords
5. How Responses Work

The chatbot:

Splits user input into words
Ignores unnecessary words (e.g. "what", "is", "the")
Matches keywords:
Keyword	Response Type
phishing	Phishing info
password	Password safety
browsing	Safe browsing tips

Example:

User: what is phishing
Bot: Phishing is when scammers pretend to be trusted sources...
6. Typing Effect

All responses use:

AsciiLogo.TypeText(message);

This creates a typing animation using:

Thread.Sleep(30);
⚙️ Continuous Integration (CI)

This project uses GitHub Actions to automatically:

Build the project
Run the application
Ensure no errors occur
 CI Mode (Important)

Since the chatbot requires user input, CI mode disables interaction:

bool isCI = Environment.GetEnvironmentVariable("CI") == "true";

if (isCI)
{
    Console.WriteLine("CI Mode: Skipping chatbot.");
    return;
}

This prevents:

Infinite loops
Build failures
 CI Workflow Success

Below is a screenshot showing a successful CI run (green check mark):

 Replace ci-success.png with your actual screenshot file from GitHub Actions.

 How to Run the Project
1. Clone Repository
git clone https://github.com/your-username/CyberBot.git
cd CyberBot
2. Run Application
dotnet run
 Required Files

Ensure these files are included:

CyberBotimage.jpg
greeting.wav

Set:

Copy to Output Directory → Copy if newer
Notes
Works best in Visual Studio or terminal
CI environment skips interactive features
Requires .NET SDK installed
 Author

Kgatla Mahlatse Norman
Diploma in IT (Software Development)
Aspiring Software Developer


---

#  How to add the CI screenshot (VERY IMPORTANT)

### Step 1:
Go to your GitHub repo → **Actions tab**

### Step 2:
Click your latest workflow run (green )

### Step 3:
Take a screenshot

### Step 4:
Save it as:

ci-success.png


### Step 5:
Put it in your project root (same level as README)

### Step 6:
Push it:
