import { Author } from "src/models/author";
import * as AuthorActions from 'src/app/state/actions/author.actions';
import { createSelector, createReducer, on } from "@ngrx/store";
import { Action } from "@ngrx/store/src/models";
import { AppState } from "../app.state";

export interface AuthorState {
    list: Author[],
    loading: boolean,
    error: Error
}

export const initialState = {
    list: [],
    loading: false,
    error: undefined
};

export const authorReducer = createReducer(
    initialState,
    on(AuthorActions.FetchAuthor, state => (console.log('fetch reducer called'), {
        ...state,
        loading: true,

    })),
    on(AuthorActions.LoadAuthorSuccess, (state, { authors }) => (
        (console.log('LoadAuthorSuccess reducer called'),
            {
                ...state,
                list: authors,
                loading: false
            })),
    ),

    on(AuthorActions.LoadAuthorFailure, (state, { error }) => (
        (console.log('LoadauthorSuccess reducer called'), {
            ...state,
            error: error,
            loading: false
        })),
    ),
);

export function reducerAuthor(state: AuthorState | undefined, action: Action) {
    return authorReducer(state, action);
}

const getAuthorFeatureState = (state: AppState) => state.author;

export const getAuthors = createSelector(
    getAuthorFeatureState,
    (state: AuthorState) => state.list
);
