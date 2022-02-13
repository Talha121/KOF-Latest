/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AllSalesmansComponent } from './AllSalesmans.component';

describe('AllSalesmansComponent', () => {
  let component: AllSalesmansComponent;
  let fixture: ComponentFixture<AllSalesmansComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AllSalesmansComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AllSalesmansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
