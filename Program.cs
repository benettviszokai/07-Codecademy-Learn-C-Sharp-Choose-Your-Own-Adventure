using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Asking the user's name
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

      // Starting the story
      // Intro & first question
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
      Console.Write("Type YES or NO: ");
      string noiseChoice = Console.ReadLine().ToUpper();

      // If the user's first answer is no, the story ends.
      if (noiseChoice == "NO") {
        Console.WriteLine("Not much of an adventure if we don't leave our room!");
        Console.WriteLine("THE END.");
      }
      // If the user's first answer is yes, the story goes on.
      else if (noiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
        Console.WriteLine("Type OPEN or KNOCK");
        string doorChoice = Console.ReadLine().ToUpper();
        
        // If the user chooses knocking on the door
        if (doorChoice == "KNOCK") {
          // Riddle
          Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
          // The user answers the riddle
          Console.Write("Type your answer: ");
          string riddleAnswer = Console.ReadLine().ToUpper();
            // If the answer is right
            if (riddleAnswer == "NOTHING") {
              Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. THE END.");
            }
            // If the answer is wrong
            else {
              Console.WriteLine("You answered incorrectly. The door doesn't open. THE END.");
            }
        }

        // If the user chooses to open the door
        else if (doorChoice == "OPEN") {
          Console.WriteLine("The door is locked! See if one of your three keys will open it.");
          // Choosing a key
          Console.Write("Enter a number: (1-3)");
          string keyChoice = Console.ReadLine().ToUpper();

          // Multiple key choices with switch
          switch (keyChoice) {
            case "1":
              Console.WriteLine("You choose the first key. Lucky choice! The door opens and NOTHING is there. Strange... THE END.");
              break;
            case "2":
              Console.WriteLine("You choose the second key. The door doesn't open. THE END.");
              break;
            case "3":
              Console.WriteLine("You choose the third key. The door doesn't open. THE END.");
              break;

            // If the user fails to choose a valid key.
            default:
              Console.WriteLine("You failed to enter a valid number. The door remains a secret... THE END.");
              break;
          }
        }
      }      
    }
  }
}
