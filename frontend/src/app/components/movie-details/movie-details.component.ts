import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieService } from 'src/app/services/movie.service';
import { MovieModel } from 'src/app/models/movie.model';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css'],
})
export class MovieDetailsComponent implements OnInit {
  movieDetails?: MovieModel;

  get languageIsDefined(): boolean {
    return (this.movieDetails && this.movieDetails.language != null) || false;
  }

  get locationIsDefined(): boolean {
    return (this.movieDetails && this.movieDetails.location != null) || false;
  }

  get soundEffectsAreDefined(): boolean {
    const soundEffects =
      (this.movieDetails && this.movieDetails.soundEffects) || [];
    return soundEffects.length > 0;
  }

  constructor(
    private route: ActivatedRoute,
    private movieService: MovieService
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe((params) => {
      const id: number = Number(params.get('id'));

      console.log(id);
      this.movieService
        .getMovieById(id)
        .subscribe((result) => (this.movieDetails = result));
    });
  }
}
