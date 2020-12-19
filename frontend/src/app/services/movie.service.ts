import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieModel } from 'src/app/models/movie.model';
import { SearchFormMoviesModel } from '../models/search-for-movies.model';

@Injectable({
  providedIn: 'root',
})
export class MovieService {
  baseUrl = `http://localhost:3000/movies`;

  constructor(private httpClient: HttpClient) {}

  getAllMovies(): Observable<MovieModel[]> {
    return this.get<MovieModel[]>(this.baseUrl);
  }

  getMovieById(id: number): Observable<MovieModel> {
    return this.get<MovieModel>(`${this.baseUrl}/${id}`);
  }

  searchForMovies(params: SearchFormMoviesModel): Observable<MovieModel[]> {
    return this.get<MovieModel[]>(`${this.baseUrl}?q=${params.title}`);
  }

  private get<T>(url: string): Observable<T> {
    return this.httpClient.get<T>(url);
  }
}
