function editElement(reference, match, replacer) {
    const content = reference.textContent;
    const matcher = new RegExp(match, 'g');
    const replaced = content.replace(matcher, replacer);
    reference.textContent = replaced;
}