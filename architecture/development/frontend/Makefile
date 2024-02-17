.PHONY: initialize-new-project

initialize-new-project:
	docker run \
		--name initiator \
		--rm \
		-v ./../../src/frontend:/var/www \
		-w /var/www \
		node \
		npx create-react-app ${REACT_APP_NAME}
