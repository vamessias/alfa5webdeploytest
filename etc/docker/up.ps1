docker network create alfa5 --label=alfa5
docker-compose -f docker-compose.infrastructure.yml up -d
exit $LASTEXITCODE