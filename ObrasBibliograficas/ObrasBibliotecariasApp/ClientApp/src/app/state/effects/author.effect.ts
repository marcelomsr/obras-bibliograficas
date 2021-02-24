import { Injectable } from "@angular/core";
import { Actions, ofType, createEffect } from '@ngrx/effects';
import { AuthorService } from "src/app/services/author.service";
import { mergeMap, map, catchError, tap, switchMap } from "rxjs/operators";
import {
    LoadAuthorSuccess, FetchAuthor, LoadAuthorFailure
} from "src/app/state/actions/author.actions";
import { of } from 'rxjs';
import { Router } from "@angular/router";

@Injectable()
export class AuthorEffect {
    constructor(
        private actions$: Actions,
        private _authorService: AuthorService,
        private _router: Router,
    ) { }

    loadAuthor$ = createEffect(() =>
        this.actions$.pipe(
            ofType(FetchAuthor),
            switchMap(() =>
                this._authorService.getAuthors().pipe(
                    map((authors) => LoadAuthorSuccess({ authors })),
                    catchError(error => of(LoadAuthorFailure({ error })))
                )
            )
        ),
    )
}
