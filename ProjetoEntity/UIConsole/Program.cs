using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacao;
using Dominio;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //ListaDeProdutoAplicacao appLista = new ListaDeProdutoAplicacao();
            //ProdutoAplicacao appProduto = new ProdutoAplicacao();

            //var lista01 = appLista.Listar().FirstOrDefault();
            //lista01.Descricao = "Cesta Basica de Rico";
            //lista01.Produtos = appProduto.Listar().ToList();

            //appLista.Excluir(lista01.Id);

            //var listas = appLista.Listar();

            //foreach (var lista in listas)
            //{
            //    Console.WriteLine("{0} - {1}", lista.Id, lista.Descricao);
            //    foreach (var produto in lista.Produtos)
            //    {
            //        Console.WriteLine("         {0} - {1}", produto.Id, produto.Nome);
            //    }
            //}

            //Console.ReadKey();

            var appCategoria = new CategoriaAplicacao();

            //var objCategoria = new Categoria();
            //objCategoria.Descricao = "Enlatados";
            //appCategoria.Salvar(objCategoria);

            //var listaDeCategorias = appCategoria.Listar();

            //foreach (var listaDeCategoria in listaDeCategorias)
            //{
            //    Console.WriteLine("{0}",listaDeCategoria.Descricao);
            //}

            //Console.ReadKey();

            //Produto
            var appProduto = new ProdutoAplicacao();
            //var objProduto = new Produto
            //{
            //    Nome = "Sardinha",
            //    Categoria = appCategoria.Listar().FirstOrDefault()
            //};
            //appProduto.Salvar(objProduto);

            //var listaDeProdutos = appProduto.Listar();

            //foreach (var listaDeProduto in listaDeProdutos)
            //{
            //    Console.WriteLine("{0} - {1}", listaDeProduto.Nome, listaDeProduto.Categoria.Descricao);
            //}

            //Console.ReadKey();

            //Lista de Produtos
            var appLista = new ListaDeProdutoAplicacao();

            var objlistaProdutos = new ListaDeProduto();
            objlistaProdutos.Descricao = "Lista de Compras do Thiago";

            var produto1 = appProduto.Listar().FirstOrDefault();

            objlistaProdutos.Produtos = new List<Produto>();
            objlistaProdutos.Produtos.Add(produto1);

            appLista.Salvar(objlistaProdutos);

            var listas = appLista.Listar();

            foreach (var listaDeProduto in listas)
            {
                Console.WriteLine("{0}", listaDeProduto.Descricao);

                foreach (var produto in listaDeProduto.Produtos)
                {
                    Console.WriteLine(" {0} - {1}", produto.Nome, produto.Categoria.Descricao);
                }
            }

            Console.ReadKey();
        }
    }
}
