using System.IO;
using UnityEngine;

public static class GerenciadorDeArquivo {
    private static string caminho = Application.persistentDataPath + "/metas.json";

    public static void SalvarMetas(ListaDeMetas lista) {
        string json = JsonUtility.ToJson(lista, true);
        File.WriteAllText(caminho, json);
    }

    public static ListaDeMetas CarregarMetas() {
        if (File.Exists(caminho)) {
            string json = File.ReadAllText(caminho);
            return JsonUtility.FromJson<ListaDeMetas>(json);
        }
        return new ListaDeMetas();
    }
    
}
