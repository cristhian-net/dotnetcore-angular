import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { Headers, Response, RequestOptions } from '@angular/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';


import { ICustomer, IOrder, IState } from '../shared/interfaces';

@Injectable()
export class DataService {
    baseUrl = "/api/customers";

    constructor(private http: HttpClient, ) { }

    getCustomers(): Observable<ICustomer[]> {
        return this.http.get<ICustomer[]>(this.baseUrl)
            .pipe(
                map((customers: ICustomer[]) => {
                    return customers;
                }),
                catchError(this.handleError)
            )
    }

    getCustomer(id: string): Observable<ICustomer> {
        return this.http.get<ICustomer>(`${this.baseUrl}/${id}`)
            .pipe(
                map((customer: ICustomer) => customer),
                catchError(this.handleError)
            )
    }

    getStates(): Observable<IState[]> {
        return this.http.get<IState[]>('api/states')
            .pipe(
                map((states: IState[]) => {
                    return states;
                }),
                catchError(this.handleError)
            )
    }

    private handleError(error: HttpErrorResponse) {
        console.error('server error:', error);
        if (error.error instanceof Error) {
            let errMessage = error.error.message;
            return Observable.throw(errMessage);
        }
        return Observable.throw(error || 'ASP.NET Core server error');
    }
}