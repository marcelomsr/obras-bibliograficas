import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Author } from 'src/models/author';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  myAppUrl = '';

  constructor(private _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.myAppUrl = baseUrl;
  }

  getAuthors() {
    console.log('service called');
    return this._http.get<Author[]>(this.myAppUrl + 'api/Author/Index').pipe(map(
      response => {
        return response;
      }));
  }
}
