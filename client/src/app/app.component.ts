import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',//richiamo questo selector in index.html per usare questo component
  templateUrl: './app.component.html',//richiama il file html così chiamato
  styleUrls: ['./app.component.css']  //richiama il file css così chiamato
})
export class AppComponent implements OnInit{
  title = 'DatingApp!'; //questo title viene richiamato con doppie graffe nel file html component
  users: any;

  constructor(private http: HttpClient) {}
  ngOnInit(): void { //qui facciamo la richiesta al server API
    this.http.get('https://localhost:5001/api/users').subscribe({ //prende i dati
    next: response => this.users = response,
    error: error => console.log(error),
    complete: () => console.log('Request has completed')
    })
  }

}
