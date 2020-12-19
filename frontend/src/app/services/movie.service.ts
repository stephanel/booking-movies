import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MovieModel } from 'src/app/models/movie.model';

@Injectable({
  providedIn: 'root',
})
export class MovieService {
  constructor(private httpClient: HttpClient) {}

  getAllMovies(): Observable<MovieModel[]> {
    const url = 'http://localhost:3000/movies';
    return this.httpClient.get<MovieModel[]>(url);
  }

  getMovieById(id: number): Observable<MovieModel> {
    const url = 'http://localhost:3000/movies/' + id;
    return this.httpClient.get<MovieModel>(url);
  }
}
