using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Statki
{
  public class Record
  {
    Result[] results;

    public Record()
    {
      try
      {
        Load();
      }
      catch 
      {
        New();
      }
    }

    private void New()
    {
      results = new Result[10];
    }

    private void Load()
    {
      // Wczytywanie listy najlepszych wyników z pliku
    }

    public void Save()
    {
      // Nadpisanie listy najlepszych wyników do pliku
    }

    private Result[] GetResults()
    {
      return results;
    }

    private bool CheckResult(Result result)
    {
      if(result != null)
        return true;
      else 
        return false;
    }

    public void AddResultToRecords(Result result)
    {
      int last_record = results.Count();

      if (CheckResult(result))        
        results[last_record] = result;
    }


  }
}
