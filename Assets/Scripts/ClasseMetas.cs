using System.Collections.Generic;
using System;

[Serializable]
public class Meta {
    public string titulo;
    public string descricao;
    public bool concluida;
}

[Serializable]
public class ListaDeMetas {
    public List<Meta> metas = new List<Meta>();
}
