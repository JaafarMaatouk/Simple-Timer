# Simple Timer Program (C# WinForms)

A desktop-based Timer application developed using C# and Windows Forms (WinForms). This project demonstrates the use of event-driven programming, specifically handling the Timer control and its Tick event.

## Project Overview
This application provides a straightforward graphical interface to control a digital timer. It is designed to practice UI state management and real-time updates in Windows Forms.

## Features
- **Start Timer:** Initiates the count-up process.
- **Stop Timer:** Pauses the timer at the current count.
- **Reset Timer:** Stops the timer and resets the counter back to zero.
- **Real-Time Display:** Updates the UI every second using the Timer control.

## Technical Details
- **Language:** C#
- **Framework:** Windows Forms (WinForms)
- **Event-Driven Programming:** Utilizes the `Timer_Tick` event to increment the time and update the label.
- **State Management:** Handles the enabling and disabling of buttons to prevent logical errors (e.g., clicking start multiple times).

## How to Run
1. Clone this repository or download it as a ZIP file.
2. Open the `.sln` file in **Visual Studio**.
3. Press `F5` or `Ctrl + F5` to build and run the application.
4. Use the buttons to start, stop, and reset the timer.

## License
This project is open-source and available under the MIT License.
