CONTAINER_RUNTIME ?= podman

.PHONY: containerized
containerized:
	rm -rf ./bin
	${CONTAINER_RUNTIME} build -t mono-build -f images/ .
	${CONTAINER_RUNTIME} run --name tray-build mono-build sh -c "nuget restore && xbuild CRCTray.sln"
	${CONTAINER_RUNTIME} cp tray-build:/app/bin ./bin
	${CONTAINER_RUNTIME} rm tray-build
	#${CONTAINER_RUNTIME} rmi mono-build  # this forces a rebuild of the toolchain each time
