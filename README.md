# FilManager

**FilManager** is a desktop application built to support 3D printing enthusiasts and businesses by tracking filament usage, managing printer operations, and calculating associated costs. This project was developed as a high school graduation thesis (*lucrare de atestat*) by **Durdeu Vlad Ioan**, and it proudly earned **First Place** in a National Computer Science Project Competition in 2022.

---

## 🧠 Project Motivation

Owning and maintaining 3D printers involves more than just operating hardware—it requires effective tracking tools that were simply nonexistent in the software market. Commercial apps were becoming outdated and lacked the features required by modern 3D printing needs. 

FilManager was born out of necessity and built by a 3D printing enthusiast, for other enthusiasts. The application supports:
- Secure user login and registration
- Email-based account recovery
- Secure database operations filtered per user
- Tools for business cost estimations

FilManager simplifies 3D printer management and represents a small revolution for anyone operating custom print services.

---

## 💻 System Requirements

### Software
- Windows 2000/XP/Vista/7/8

### Hardware
- CPU: 500 MHz (min) / 1 GHz (recommended)
- RAM: 128 MB (min) / 256 MB (recommended)
- GPU: 64 MB (min) / 128 MB (recommended)
- Disk Space: 200 MB
- CD/DVD drive

---

## 🔐 Features

### User Authentication
- Login and registration interfaces
- Email verification with temporary password
- Secure login via personal password after first use
- Password recovery with secure email process

### Dashboard
- Split layout: navigation panel (left) + database view (right)
- 11 functional buttons including logout, app exit, contact developer, password change

### Database Management
- Add, edit, delete, view data securely
- Only the logged-in user's data is visible
- Data displayed with helpful visual cues:
  - *Italic gray*: unused
  - **Green bold**: selectable or required
- Cannot modify entries inline – dedicated forms are used
- Database context and forms adapt based on content

### Program Structure
- Core logic uses `DatabaseCommands` class with reusable static methods
- `SqlHelper` ensures safe data type conversion for SQL operations
- Key methods:
  - Validate user emails
  - Remove entries
  - Insert/update rows dynamically
---

## 📚 Bibliography

- Visual C# 2019 Programming
- Photoshop, Photopea ([photopea.com](https://www.photopea.com)), Paint.NET
- Online references:
  - [StackOverflow](http://stackoverflow.com)
  - [MSDN Documentation](http://msdn.microsoft.com/en-us/library/ms228277%28v=vs.90%29.aspx)
- Course content from Prof. Kelemen Erzsébet

---

## 👨‍💻 Author

- **Durdeu Vlad Ioan**  
  Class: XII-F  
  Project Advisor: Prof. Kelemen Erzsébet & Prof. Nagy István

---

## 🏆 Awards

🥇 **Winner of First Place – Computer Science Project Competition in Salonta (2022)**
