import { Component, OnInit } from '@angular/core';
import { MovieModel } from 'src/app/models/movie.model';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-movies-list',
  templateUrl: './movies-list.component.html',
  styleUrls: ['./movies-list.component.css'],
})
export class MoviesListComponent implements OnInit {
  movies: MovieModel[] = [];

  constructor(private movieService: MovieService) {}

  ngOnInit() {
    this.movieService
      .getAllMovies()
      .subscribe((results) => (this.movies = results));
  }
}
