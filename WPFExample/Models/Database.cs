using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus;

namespace WPFExample.Models
{
  public static class Database
  {
    public static IList<IAuthor> GenerateRandomAuthors(Int32 count = 10)
    {
      var result = new Faker<IAuthor>()
        .CustomInstantiator(_ => new Author())
        .RuleFor(x => x.FirstName, x => x.Name.FirstName())
        .RuleFor(x => x.LastName, x => x.Name.LastName())
        ;
      return result.Generate(count);
    }

  }
}
