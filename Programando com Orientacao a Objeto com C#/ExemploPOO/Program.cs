﻿using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno p1 = new Aluno();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Documento = "123456";
            p1.Nota = 10;
            p1.Apresentar();
            
            Professor p2 = new Professor();
            p2.Nome = "Leo";
            p2.Idade = 20;
            p2.Documento = "123456";
            p2.Salario = 1000;
            p2.Apresentar();

//===========================================================================
            // Valores Validos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);
            
            // System.Console.WriteLine($"Area: {r.ObterArea()}");

            // // Valores Invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            
            // System.Console.WriteLine($"Area: {r2.ObterArea()}");

//===========================================================================

            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            
            // p1.Apresentar();
        }
    }
}