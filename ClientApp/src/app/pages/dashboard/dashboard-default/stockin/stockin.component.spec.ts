/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { StockinComponent } from './stockin.component';

describe('StockinComponent', () => {
  let component: StockinComponent;
  let fixture: ComponentFixture<StockinComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StockinComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StockinComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
