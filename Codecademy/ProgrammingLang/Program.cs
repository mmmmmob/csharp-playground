using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;

namespace ProgrammingLanguages
{
  class Program
  {
    static void Main()
    {
      List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

      // * Print all language with manual Prettify
      var prettify = languages.Select(language => $"({language.Year}) {language.Name} created by {language.ChiefDeveloper}");
      PrettyPrintAll(languages); // <- same as above

      // * Query for C# (Method Chaining)
      var csharp = languages.Where(lang => lang.Name.Contains("C#")).Select(lang => lang.Prettify());

      // * Query for language mad by Microsoft
      var madeByMS = languages.Where(lang => lang.ChiefDeveloper.Contains("Microsoft")).Select(lang => lang.Prettify());

      // * Query for Lisp successors (Query Syntax)
      var lispSuccessors = from lang in languages
                           where lang.Predecessors.Contains("Lisp")
                           select lang;

      // * Query for "Script" in language name
      var nameWithScript = from lang in languages
                           where lang.Name.Contains("Script")
                           select lang.Name;

      // * Query for number of language between 1995 - 2005
      Console.WriteLine(languages.Count); // 119 langs in tsv file
      var Y2Klangs = languages.Where(lang => lang.Year <= 2005 && lang.Year >= 1995).Select(lang => $"{lang.Name} was invented in {lang.Year}");
      Console.WriteLine(Y2Klangs.Count()); // 66 langs in Y2K range
      PrintAll(Y2Klangs);

    }

    // ! for use with List in Language class
    public static void PrettyPrintAll(IEnumerable<Language> langs)
    {
      foreach (Language lang in langs)
      {
        Console.WriteLine(lang.Prettify());
      }
    }

    // ! for use with query result (var)
    public static void PrintAll(IEnumerable<Object> langs)
    {
      foreach (Object lang in langs)
      {
        Console.WriteLine(lang);
      }
    }
  }
}
