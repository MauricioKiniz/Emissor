namespace MKSistemas

module Validacao =
    open System

    // funcoes genericas de validacao
    let stringVaziaOuNula str = 
        match str with
        | Some str -> System.String.IsNullOrEmpty(str)
        | None -> true

    let stringComDoisOuMaisCaracteres str = 
        if stringVaziaOuNula str then 
            false 
        else 
            str.Value.Length > 2
    
    let stringNula str = 
        match str with
        | Some str -> (str = null)
        | None -> true
