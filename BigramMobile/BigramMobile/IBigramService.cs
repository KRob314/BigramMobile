using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BigramAndHistogram.Services
{
    public interface IBigramService
    {
        string GetOutput(List<Bigram> bigrams);
        string[] SplitWords(string input);
        List<Bigram> GetSequence(string[] words);
    }
}
