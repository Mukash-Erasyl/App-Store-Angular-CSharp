import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BaselComponent } from './basel.component';

describe('BaselComponent', () => {
  let component: BaselComponent;
  let fixture: ComponentFixture<BaselComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BaselComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BaselComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
