/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { MainPosComponent } from './MainPos.component';

describe('MainPosComponent', () => {
  let component: MainPosComponent;
  let fixture: ComponentFixture<MainPosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainPosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainPosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
