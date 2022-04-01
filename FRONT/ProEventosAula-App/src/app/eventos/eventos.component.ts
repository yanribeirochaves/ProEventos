import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltrados: any = [];
  public larguraImagemGrid = 200;
  public mostrarImagem = false;
  private _filtroLista: string = '';

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  public get filtroLista() : string {
    return this._filtroLista;
  }

  public set filtroLista(value){
    this._filtroLista = value;
    this.eventosFiltrados = this._filtroLista !== '' ? this.filtrarEventos(this._filtroLista) : this.eventos;
  }

  public filtrarEventos(value : string) : any{
    if(value != ''){
      return this.eventos.filter(
          (evento : any) => evento.tema.toLocaleLowerCase().indexOf(value.toLocaleLowerCase()) !== -1 ||
          evento.local.toLocaleLowerCase().indexOf(value.toLocaleLowerCase()) !== -1
      );
    }
    else{
      return this.eventos;
    }
  }

  public getEventos() : void{
    this.http.get('https://localhost:5001/Evento').subscribe(
      response => {
        this.eventos = response;
        this.eventosFiltrados = this.eventos;
      },
      error => console.log(error)
    );
      //this.eventosFiltrados = this.eventos;  //aqui desse jeito nao funciona
  }

  public exibicaoImagem() : void {
    this.mostrarImagem = !this.mostrarImagem;
  }

}
