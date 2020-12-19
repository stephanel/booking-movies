import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { MovieModel } from 'src/app/models/movie.model';
import { SearchFormMoviesModel } from 'src/app/models/search-for-movies.model';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-search-movies',
  templateUrl: './search-movies.component.html',
  styleUrls: ['./search-movies.component.css'],
})
export class SearchMoviesComponent implements OnInit {
  searchForm: FormGroup = new FormGroup({});

  @Output() onFoundMovies = new EventEmitter<MovieModel[]>();

  constructor(
    private formBuilder: FormBuilder,
    private movieService: MovieService
  ) {}

  ngOnInit() {
    this.searchForm = this.formBuilder.group({
      title: null,
    });
  }

  formIsEmpty(): boolean {
    return this.searchForm.pristine;
  }

  onSubmit() {
    const params: SearchFormMoviesModel = this.searchForm
      .value as SearchFormMoviesModel;
    this.movieService.searchForMovies(params).subscribe((results) => {
      this.onFoundMovies.emit(results);
    });
  }
}
