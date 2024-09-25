use actix_web::{web, App, HttpServer};
use dotenv::dotenv;
use sqlx::SqlitePool;

mod api;
mod models;

#[actix_web::main]
async fn main() -> std::io::Result<()> {
    dotenv().ok();

    // Create a connection pool to SQLite
    let pool = SqlitePool::connect(&std::env::var("DATABASE_URL").expect("DATABASE_URL not set"))
        .await
        .expect("Failed to create pool");

    HttpServer::new(move || {
        App::new()
            .app_data(web::Data::new(pool.clone()))
            // Define routes
            .route("/users", web::get().to(api::get_users))
            .route("/users", web::post().to(api::create_user))
            .route("/users/{id}", web::get().to(api::get_user))
            .route("/users/{id}", web::delete().to(api::delete_user))
    })
    .bind(("127.0.0.1", 8080))?
    .run()
    .await
}
