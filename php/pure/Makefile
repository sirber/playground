.PHONY: build dev stop

build:
	@docker compose build
	@cd src && composer install
	@cd src && composer dump-autoload

dev: build
	@docker compose up -d
	@echo "ready! open: http://localhost"

stop:
	@docker compose stop