using System;

namespace myApp
{
  class Program
  {

     static void Main(string[] args)
    {
      Console.WriteLine("Hello Nipsey Hussle Fan, to see your favorite quotes please type a number from 1 - 10!");
      string stringUserNumber = Console.ReadLine();
      int intUserNumber = int.Parse(stringUserNumber);

      if (intUserNumber == 10)
      {
        Console.WriteLine("The company you keep has a large influence on the situations you bring to yourself. Birds of a feather flock together.");
      } else if (intUserNumber == 9)
      {
        Console.WriteLine("The most important thing, number one, is you gotta get rid of doubt. If you got doubt in what you're doing, it's not gonna work and the way to do that is to have a plan. 'Cause if you got a plan, it's not just like a pipe-dream, you have a step-by-step list of things to do to get to your goal. If you don't have that, it's very hard to really have faith in what you're doing 'cause soon as something pop up, it's gonna look like the end-all.");
      }
      else if (intUserNumber == 8)
      {
        Console.WriteLine("You gotta go hard, you have to believe in yourself. You gotta have a sense of humor to know that the bullshit is gonna happen, you can't be too serious about it or too emotional and fake when the bullshit happens. You gotta just stick to the script, believe and have an overwhelming confidence. Be your own biggest fan, your own biggest believer, and put it on your back and carry the weight.");
      }
      else if (intUserNumber == 7)
      {
        Console.WriteLine("Longwinded, running through this life like it was mine. Never settling, but setting every goal high. One thousand burpees on the path to my own destruction or success. But what is a mistake without the lesson? See, the best teacher in life is your own experience. None of us know who we are until we fail. They say every man is defined by his reaction to any given situation. Well who would you want to define you? Someone else or yourself? Whatever you do, homie, give your heart to it and stay strong.");
      }
      else if (intUserNumber == 6)
      {
        Console.WriteLine("The best thing you can do for a person is to inspire them. That's the best currency you can offer: inspiration. So, when a person can rely on you for that, that empowers them in every realm of their life. Being inspired. It empowers them in their relationships, in their business, in their art, and in their creativity. It empowers them because without (in)spiration, you're empty.");
      }
      else if (intUserNumber == 5)
      {
        Console.WriteLine("Define who you are and what you are, and be clear on that. Meditate on that and then, live and die by that. You can't break the rules, the fundamental rules. Be a man of your word, do what you say you're gonna do, respect people the way you would like to be respected.");
      }
      else if (intUserNumber == 4)
      {
        Console.WriteLine("Thought is powerful in all phases. Even in my career, even in my life, things end up exactly how I visualized them.");
      }
      else if (intUserNumber == 3)
      {
        Console.WriteLine("On a mission your worst enemy is idle time.");
      }
      else if (intUserNumber == 2)
      {
        Console.WriteLine("I’m about seeing long-term, seeing a vision, understanding nothing really worthwhile happens overnight, and just sticking to your script long enough to make something real happen.");
      }
      else if (intUserNumber == 1)
      {
        Console.WriteLine("It's possible to monetize your art without compromising the integrity of it for commerce.");
      }
      else if (intUserNumber == 1)
      {
        Console.WriteLine("It's possible to monetize your art without compromising the integrity of it for commerce.");
      }
      else {
        Console.WriteLine("Invalid input, try the numbers 1-10.");
      }

        }
      }
    }
