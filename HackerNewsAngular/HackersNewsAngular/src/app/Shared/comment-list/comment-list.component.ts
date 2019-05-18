import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-comment-list',
  templateUrl: './comment-list.component.html',
  styleUrls: ['./comment-list.component.scss']
})
export class CommentListComponent implements OnInit {

  @Input()
  commentIds = new Array<number>();

  commentView = false;

  loadingInd = false;

  constructor() { }

  ngOnInit() {
  }

  loading(event) {
    setTimeout(() => {
      if (event != this.loadingInd) {
        this.loadingInd = event;
      }
    });
  }
}
