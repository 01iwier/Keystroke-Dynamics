# Keystroke Dynamics

Keystroke Dynamics is a C# application designed to identify users based on their unique typing and mouse movement patterns. By collecting and analyzing characteristic features from keyboard and mouse interactions, the application can accurately recognize users even when they log in anonymously.

## Features
* Collects typing patterns and mouse movement data through interactive tests.
* Extracts characteristic features from the test data.
* Stores collected data in a database.
* Allows users to create profiles to store their test data.
* Locates the closest profile match based on a set of anonymous testing data.

## Usage
1. **Create a New Profile**
   * Open the new user form and provide a valid username and password.
   * Save the new profile.

  <img src="https://github.com/user-attachments/assets/7e5c7308-85b3-4dc4-8cd5-4bb0d3e84c39" width="200">
<br>
<br>

2. **Update Profile**
   * Select your profile from the drop-down list and enter your password.
   * Start a typing test or mouse test and follow the instructions provided.
   * Save your test once completed.
   * (Tests should be completed multiple times in order to produce an accurate set of metrics)

<img src="https://github.com/user-attachments/assets/5bc1298a-2f5b-4f15-a162-6671b8fa02b4" width="300">
<img src="https://github.com/user-attachments/assets/18948cb7-02eb-4fd3-8ba8-a10634116eb7" width="345">
<br>
<br>

3. **Identify Anonymous User**
   * Perform both tests as an anonymous user at least once.
   * Press 'Identify User'.
   
## Installation
### Prerequisites
  * Windows OS
  * .NET Runtime
  * SQL Server / LocalDB
### Steps
  * Download and run [setup.exe](https://github.com/01iwier/Keystroke-Dynamics/blob/master/KeystrokeDynamics/setup/setup.exe)
  * Follow the installation instructions.
  * Once installed, launch the application from Start Menu.
