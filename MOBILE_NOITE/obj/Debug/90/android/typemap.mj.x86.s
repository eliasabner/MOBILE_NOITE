	/* Data SHA1: d5423a0c79eebf7b6a58ccb96e54b30ef15c3e2e */
	.file	"typemap.mj.inc"

	/* Mapping header */
	.section	.data.mj_typemap,"aw",@progbits
	.type	mj_typemap_header, @object
	.p2align	2
	.global	mj_typemap_header
mj_typemap_header:
	/* version */
	.long	1
	/* entry-count */
	.long	9
	/* entry-length */
	.long	113
	/* value-offset */
	.long	52
	.size	mj_typemap_header, 16

	/* Mapping data */
	.type	mj_typemap, @object
	.global	mj_typemap
mj_typemap:
	.size	mj_typemap, 1018
	.include	"typemap.mj.inc"
