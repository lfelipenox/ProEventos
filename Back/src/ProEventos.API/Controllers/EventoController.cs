﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {   
        // public IEnumerable<Evento> _evento = new Evento[]{
        //     new Evento(){
        //         EventoId = 1,
        //         Tema = "Angular 11 e .Net 5",
        //         Local = "Campinas",
        //         Lote = "1º Lote",
        //         QtdPessoas = 250,
        //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //         ImagemURL = "foto.png"
        //     },
        //     new Evento(){
        //         EventoId = 2,
        //         Tema = "Angular e suas novidades",
        //         Local = "São Paulo",
        //         Lote = "2º Lote",
        //         QtdPessoas = 350,
        //         DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
        //         ImagemURL = "foto1.png"
        //     }
        // };

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);            
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de POST";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT {id}";
        }
        
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete {id}";
        }


    }
}
