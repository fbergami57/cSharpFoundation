//Uma stringbuilder no C# é uma classe que permite criar e modificar strings mutáveis de forma eficiente. 
//Ela é usada quando se deseja modificar uma cadeia de caracteres sem criar um novo objeto.

                            var errosLinha = new StringBuilder(); //acumula linhas de erro
                            var codigo = 0L; //Criar uma variavel tipo long
                            var tipoTabela = int.Parse(linha["Tipo Tabela"].ToString()); //analisa o valor como "int"
                            var tipoOrigemCodigo = ObterTipoOrigemCodigo(linha["Origem Código"].ToString()); //chama um metodo "ObterTipoOrigemCodigo" pra pegar o tipo por linha
                            var tiposTabelasValidos = new int[] { 22, 98 }; // codigo de tabela 22(procedimentos) e 98(pacotes)
                            #region Código
                            // Validar a linha                            
                            if (!tiposTabelasValidos.Contains(tipoTabela)) //verificar se os códigos estão entre 22 e 98
                                errosLinha.Append("Apenas os Tipos Tabela 22 e 98 são permitidos."); // se não retorna msg de erro
                            if (tipoOrigemCodigo.Equals(Convert.ToInt32(TipoOrigemCodigoEnum.Nenhum)))
                                errosLinha.Append("Código Tipo Origem inválido.");
                            if (!long.TryParse(linha["Código"].ToString(), out codigo))
                                errosLinha.Append("Código '" + linha["Código"].ToString() + "' não é um número. ");
                            if (codigo == 0)
                                errosLinha.Append("Código '" + linha["Código"].ToString() + "' não pode ser igual a 0. ");
                            if (linha["Código"].ToString().Length > 10)
                                errosLinha.Append("Código '" + linha["Código"].ToString() + "' maior do que 10 posições.");
                            #endregion
                            //Valida se existe código repetido
                            var qtdLinhas = dataTableExcel.Select("[Código]='" + codigo + "' AND [Tipo Tabela]='" + linha["Tipo Tabela"].ToString() + "'");
                            if (qtdLinhas != null && qtdLinhas.Length > 1)
                                errosLinha.Append("Código '" + linha["Código"].ToString() + "' aparece mais de uma vez no excel. ");
                            if (linha["Documentação na Racionalização"] == null || string.IsNullOrEmpty(linha["Documentação na Racionalização"].ToString()))
                            {
                                errosLinha.Append("Documentação na Racionalização é obrigatório. ");
								
								
								