import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GettrucksComponent } from './gettrucks.component';

describe('GettrucksComponent', () => {
  let component: GettrucksComponent;
  let fixture: ComponentFixture<GettrucksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GettrucksComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GettrucksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
