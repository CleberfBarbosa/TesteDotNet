using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TesteDotNet.Infra.Readers
{
    public class ReadCsv
    {
        public List<string> LerCsv(string nomeArquivo)
        {
            var listaLinhas = new List<string>();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\" + nomeArquivo);
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var linha = reader.ReadLine();
                    if (!string.IsNullOrEmpty(linha))
                        listaLinhas.Add(linha);
                }
            }
            return listaLinhas;
        }
    }
}
