import { Component, Input } from '@angular/core';
import { MovieModel } from 'src/app/models/movie.model';

@Component({
  selector: 'app-movies-table',
  templateUrl: './movies-table.component.html',
  styleUrls: ['./movies-table.component.css'],
})
export class MoviesTableComponent {
  @Input() movies: MovieModel[] = [];
}
