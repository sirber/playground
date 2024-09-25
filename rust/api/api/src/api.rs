use actix_web::{web, HttpResponse, Responder};
use sqlx::SqlitePool;

use crate::models::{CreateUser, User};

pub async fn get_users(pool: web::Data<SqlitePool>) -> impl Responder {
    let users = sqlx::query_as::<_, User>("SELECT * FROM users")
        .fetch_all(pool.get_ref())
        .await;

    match users {
        Ok(users) => HttpResponse::Ok().json(users),
        Err(_) => HttpResponse::InternalServerError().finish(),
    }
}

pub async fn create_user(
    pool: web::Data<SqlitePool>,
    new_user: web::Json<CreateUser>,
) -> impl Responder {
    let result = sqlx::query("INSERT INTO users (name, email) VALUES (?, ?)")
        .bind(&new_user.name)
        .bind(&new_user.email)
        .execute(pool.get_ref())
        .await;

    match result {
        Ok(_) => HttpResponse::Ok().json("User created"),
        Err(_) => HttpResponse::InternalServerError().finish(),
    }
}

pub async fn get_user(pool: web::Data<SqlitePool>, user_id: web::Path<i64>) -> impl Responder {
    let user: Result<_, _> = sqlx::query_as::<_, User>("SELECT * FROM users WHERE id = ?")
        .bind(user_id.into_inner())
        .fetch_one(pool.get_ref())
        .await;

    match user {
        Ok(user) => HttpResponse::Ok().json(user),
        Err(_) => HttpResponse::NotFound().json("User not found"),
    }
}

pub async fn delete_user(pool: web::Data<SqlitePool>, user_id: web::Path<i64>) -> impl Responder {
    let result = sqlx::query("DELETE FROM users WHERE id = ?")
        .bind(user_id.into_inner())
        .execute(pool.get_ref())
        .await;

    match result {
        Ok(_) => HttpResponse::Ok().json("User deleted"),
        Err(_) => HttpResponse::InternalServerError().finish(),
    }
}
