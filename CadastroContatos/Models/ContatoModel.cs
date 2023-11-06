﻿using System.ComponentModel.DataAnnotations;

namespace CadastroContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do contato!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o email do contato!")]
        [EmailAddress(ErrorMessage ="O email é inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do contato!")]
        [Phone(ErrorMessage ="O celular informado não é válido!")]
        public string Celular { get; set; }
    }
}
