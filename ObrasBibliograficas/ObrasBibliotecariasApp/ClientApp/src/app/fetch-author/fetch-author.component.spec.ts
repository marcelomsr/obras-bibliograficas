import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FetchAuthorComponent } from './fetch-author.component';

describe('FetchAuthorComponent', () => {
  let component: FetchAuthorComponent;
  let fixture: ComponentFixture<FetchAuthorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FetchAuthorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FetchAuthorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
