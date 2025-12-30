# Common Task Manager
A program that controls daily tasks. No information stored (volatile mem).

>Status: debugging 🐌<br>
>Version: 1.0<br>
>Date released: 12/30/2025

## Content
Single form without dependencies.
One textbox, two listBoxes three buttons, a menuStrip, a timer and statusStrip.

## How does it work? - Behavior
A task can be created when isn't null, by clicking in "Add" button:
* Add - adds a task per once in the "pending" listbox.
* Remove - removes the selected task from "pending" listbox.
* Finish task - finishes the selected task and adds in the "completed" listbox.

All tasks are registered with time stamp but aren't stored in memory (volatile).

## What was used? - Resources
GUI          | .NET  | SQL | Web
------------ | ----- | --- | ---
Windows Forms| v.8.0 | No  | No
