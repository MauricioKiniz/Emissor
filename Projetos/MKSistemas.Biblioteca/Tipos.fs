namespace MKSistemas
    open System

    type Identificador = Guid   
    type RecursoId = Identificador
    type NomeBase = string
    type DescricaoBase = string

    type Requisicao<'data> =
        {
            Data: 'data;
            DataRequisicao: DateTime;
            IdUsuario: Identificador
        }
