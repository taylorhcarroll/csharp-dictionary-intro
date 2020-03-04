using System;
using System.Collections.Generic;

namespace csharp_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>() {
                {"lilo", "n. a friendship that can lie dormant for years only to pick right back up instantly, as if no time had passed since you last saw each other."},
                {"onism", "n. the frustration of being stuck in just one body, that inhabits only one place at a time, which is like standing in front of the departures screen at an airport, flickering over with strange place names like other people’s passwords, each representing one more thing you’ll never get to see before you die—and all because, as the arrow on the map helpfully points out, you are here."},
                {"scabulous", "adj. proud of a scar on your body, which is an autograph signed to you by a world grateful for your continued willingness to play with her, even when you don’t feel like it."},
                {"wytai", "n. a feature of modern society that suddenly strikes you as absurd and grotesque—from zoos and milk-drinking to organ transplants, life insurance, and fiction—part of the faint background noise of absurdity that reverberates from the moment our ancestors first crawled out of the slime but could not for the life of them remember what they got up to do."},
                {"exulansis", "n. the tendency to give up trying to talk about an experience because people are unable to relate to it—whether through envy or pity or simple foreignness—which allows it to drift away from the rest of your life story, until the memory itself feels out of place, almost mythical, wandering restlessly in the fog, no longer even looking for a place to land."},
                {"sonder", "n. the realization that each random passerby is living a life as vivid and complex as your own—populated with their own ambitions, friends, routines, worries and inherited craziness—an epic story that continues invisibly around you like an anthill sprawling deep underground, with elaborate passageways to thousands of other lives that you’ll never know existed, in which you might appear only once, as an extra sipping coffee in the background, as a blur of traffic passing on the highway, as a lighted window at dusk."}
            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("vemödalen", "n. the frustration of photographing something amazing when thousands of identical photos already exist—the same sunset, the same waterfall, the same curve of a hip, the same closeup of an eye—which can turn a unique subject into something hollow and pulpy and cheap, like a mass-produced piece of furniture you happen to have assembled yourself.");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            string word1 = wordsAndDefinitions["sonder"];
            Console.WriteLine("sonder" + ": " + word1);
            string word2 = wordsAndDefinitions["vemödalen"];
            Console.WriteLine("vemödalen" + ": " + word2);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");

            };
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            Dictionary<string, string> excitedWord = new Dictionary<string, string>();
            Dictionary<string, string> funnyWord = new Dictionary<string, string>();
            Dictionary<string, string> wordWord = new Dictionary<string, string>();

            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "about to pee your pants");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example", "I'm soooooooo excited");

            funnyWord.Add("word", "funny");
            funnyWord.Add("definition", "a way to describe that 'ha ha' feeling");
            funnyWord.Add("part of speech", "adjective");
            funnyWord.Add("example", "The joker is funny, I think?");

            wordWord.Add("word", "Word");
            wordWord.Add("definition", "part of a sentence");
            wordWord.Add("part of speech", "noun");
            wordWord.Add("example", "I forgot what words are");

            dictionaryOfWords.Add(excitedWord);
            dictionaryOfWords.Add(funnyWord);
            dictionaryOfWords.Add(wordWord);

            foreach (var word in dictionaryOfWords)
            {
                foreach (var item in word)

                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            };
        }
    }
}
