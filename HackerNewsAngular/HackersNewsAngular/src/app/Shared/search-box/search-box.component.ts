import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-search-box',
  templateUrl: './search-box.component.html',
  styleUrls: ['./search-box.component.scss']
})
export class SearchBoxComponent implements OnInit {

  constructor() { }

  @Output()
  search = new EventEmitter<string>();

  ngOnInit() {
  }

  Keydown(event) {
    this.search.emit(event);
  }

}
