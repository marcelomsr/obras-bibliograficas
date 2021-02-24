import { Author } from "src/models/author";
import { createAction, props } from '@ngrx/store';

export enum AuthorActionTypes {
  FETCH_AUTHOR = "[AUTHOR] Fetch Author",
  FETCH_AUTHOR_SUCCESS = "[AUTHOR] Fetch Author Success",
  FETCH_AUTHOR_FAILURE = "[AUTHOR] Fetch Author Failed",
}

export const FetchAuthor = createAction(
  AuthorActionTypes.FETCH_AUTHOR
)

export const LoadAuthorSuccess = createAction(
  AuthorActionTypes.FETCH_AUTHOR_SUCCESS,
  props<{ authors: Author[] }>()
)

export const LoadAuthorFailure = createAction(
  AuthorActionTypes.FETCH_AUTHOR_FAILURE,
  props<{ error: any }>()
)
