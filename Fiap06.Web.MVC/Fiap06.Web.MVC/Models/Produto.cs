﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
    }
}