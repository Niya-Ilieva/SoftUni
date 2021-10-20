function validator(input) {
    const methods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    const versions = ['HTTP/0.9','HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0']
    const uris = /^([\w.]+)$/
    const messages = /([<>\\&']+)/

    if (!input.method || !methods.includes(input.method)) {
        throw new Error(`Invalid request header: Invalid Method`)
    }
    if (!input.uri || !uris.test(input.uri) || input.uri == '') {
        throw new Error(`Invalid request header: Invalid URI`)
    }
    if (!input.version || !versions.includes(input.version)) {
        throw new Error(`Invalid request header: Invalid Version`)
    }
    if (input.message == undefined || messages.test(input.message)) {
        throw new Error(`Invalid request header: Invalid Message`)
    }

    return input;
}
console.log(validator({
    method: 'GET',
    uri: 'svn.public.catalog',
    version: 'HTTP/1.1',
    //message: ''
  }
  ));