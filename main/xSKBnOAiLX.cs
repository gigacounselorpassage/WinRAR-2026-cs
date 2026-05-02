using System;
using System.Collections.Generic;
using System.Linq;
namespace StringUtilities{
public class StringProcessor{
public static List<string> GetUniqueWords(string input){
HashSet<string> uniqueWords = new HashSet<string>();
if(string.IsNullOrWhiteSpace(input)){
return uniqueWords.ToList();
}
string[] words = input.Split(new char[]{' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
foreach(string word in words){
uniqueWords.Add(word.ToLower());
}
return uniqueWords.ToList();
}
public static Dictionary<string, int> GetWordFrequency(string input){
Dictionary<string, int> frequency = new Dictionary<string, int>();
if(string.IsNullOrWhiteSpace(input)){
return frequency;
}
string[] words = input.Split(new char[]{' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
foreach(string word in words){
string lowerWord = word.ToLower();
if(frequency.ContainsKey(lowerWord)){
frequency[lowerWord]++;
}else{
frequency[lowerWord] = 1;
}
}
return frequency;
}
public static string RemovePunctuation(string input){
if(string.IsNullOrWhiteSpace(input)){
return input;
}
char[] punctuation = new char[]{'.', ',', '!', '?', ';', ':'};
return new string(input.Where(c => !punctuation.Contains(c)).ToArray());
}
public static string ReverseWords(string input){
if(string.IsNullOrWhiteSpace(input)){
return input;
}
string[] words = input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
Array.Reverse(words);
return string.Join(" ", words);
}
}
}
