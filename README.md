# SharpYTPGenerator 🎬✨

A random **YouTube Poop (YTP) style generator** for **VEGAS Pro 14**, built in C# with **SharpDevelop**.  
This tool creates chaotic timelines by slicing, repeating, and remixing video/audio files into a VEGAS script.

---

## 🚀 Features
- Select a folder of media (`.mp4`, `.mov`, `.mkv`, `.mp3`, `.wav`, etc.).
- Random slicing of video/audio into short clips.
- Adjustable minimum/maximum slice lengths.
- Randomized clip counts for variety.
- Optional **audio stutter** effect (tiny slices repeated).
- Exports a **VEGAS C# script** (`.cs`) you can run inside VEGAS Pro 14.

---

## 📦 How It Works
1. Build & run the app in **SharpDevelop** (or Visual Studio 2010+).
2. Pick a media folder and configure options.
3. Click **Generate Vegas Script** → saves a `.cs` script.
4. In **VEGAS Pro 14**, go to  
   `Tools → Scripting → Run Script...`  
   and select the generated `.cs` file.
5. VEGAS builds the YTP timeline automatically!

---

## 🛠 Requirements
- .NET Framework 4.0  
- SharpDevelop 4.x (or Visual Studio 2010+)  
- VEGAS Pro 14 (tested)  

---

## 📂 Project Structure

---

## 📝 Notes
- This project does **not** generate `.veg` files directly.  
  Instead, it produces a **VEGAS C# script** that builds the timeline when run.  
- Each run creates a new randomized sequence.  
- For reproducibility, set a custom random seed in the UI.  

---

## 🔮 Roadmap
- 🎵 Pitch-shifting for memes  
- 🌈 Color/visual glitch FX  
- 🎛 More timeline control (tracks, effects, transitions)  

---

## 📜 License
MIT License – free to use, remix, and improve.  

---

💡 Tip: Run multiple generated scripts in different VEGAS projects, then splice them together for maximum chaos!

