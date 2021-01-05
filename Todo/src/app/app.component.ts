import { Component, OnInit } from '@angular/core';

import { HttpRequest, HttpClient, HttpEventType, HttpResponse } from '@angular/common/http';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'Todo';
  content = [];
  constructor(private http: HttpClient) { }
  ngOnInit(): void {
    this.http.get('api/Todo').toPromise().then((data: any) => {
      this.content = data;
    });

  }
}
