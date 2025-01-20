using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace Aula_28_Manipucao2
{
    public class ConsumirJsonparaTxt
    {
        static async Task Main(string[] args)
        {
            // Url do arquivo json contendo informações sobre animes
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            // NOme do arquivo TCT de Saida
            string nomeArquivo = "animes.txt";

            try
            {
                // HttpClient é uma classe que permite fazer requisições HTTP
                using (HttpClient cliente = new HttpClient())
                {
                    // Faz a requisição get para obter o Json
                    var response = await cliente.GetAsync(url);

                    // Le o conteudo da resposta
                    var responseString = await response.Content.ReadAsStringAsync();

                    // Deixar o json em estrutura dinimica que é o JArray
                    using (JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var animeListe = document.RootElement.GetProperty("data");

                        // Função que graa todas as informações do Json e salva em um arquivo txt
                        SalvarEmTxt(animeListe, nomeArquivo);
                    }

                    Console.WriteLine("Informações salvas com sucessor!");
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao salvar informações: " + e.Message);
            }
        }
        static void SalvarEmTxt(JsonElement animeListe, string nomeArquivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animeListe.EnumerateArray())
                    {
                        string titlle = anime.GetProperty("title").GetString() ?? "Sem Titulo";
                        string type = anime.GetProperty("type").GetString() ?? "Sem Tipo";
                        int episodes = anime.TryGetProperty("episodes", out JsonElement episodesElement) ? episodesElement.GetInt32() : 0;
                        string status = anime.GetProperty("status").GetString() ?? "Sem Status";
                        // escreve a temporada do anime
                        string season = "N/A";
                        int year = 0;

                        // if (anime.TryGetProperty("animeSeason", out JsonElement animeSeason)) //out é forma de acessar as propriedades de animeSeason
                        // {
                        //     season = animeSeason.TryGetProperty("season").GetString() ?? "N/A";
                        // }
                        writer.WriteLine($"Titulo: {titlle}");
                        writer.WriteLine($"Tipo: {type}");
                        writer.WriteLine($"Episodios: {episodes}");
                        writer.WriteLine($"Status: {status}");
                        writer.WriteLine($"Temporada: {season}");

                    }

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}