import { Component, OnInit } from '@angular/core';
import { Author } from 'src/models/author';
import { Store, select } from "@ngrx/store";
import { AppState } from '../state/app.state';
import { Observable } from 'rxjs';
import { FetchAuthor } from 'src/app/state/actions/author.actions';
import { getAuthors } from 'src/app/state/reducers/author.reducer';

@Component({
  selector: 'app-fetch-author',
  templateUrl: './fetch-author.component.html',
  styleUrls: ['./fetch-author.component.css']
})
export class FetchAuthorComponent implements OnInit {

  loading$: Observable<Boolean>;
  error$: Observable<Error>

  public autList: Observable<Author[]>;

  temp: Author[];

  constructor(private store: Store<AppState>) {
  }

  ngOnInit() {
    this.store.dispatch(FetchAuthor());
    this.autList = this.store.pipe(select(getAuthors));
    this.loading$ = this.store.select(store => store.author.loading);
  }
}
